﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPCRUD {

	public partial class Form1 : Form {
		static string connectionStringConfig = ConfigurationManager.ConnectionStrings[ "SystemDatabaseConnectionTemp" ].ConnectionString;
		string EmployeeId = "";

		#region Form1
		//--------------- < region Form1 > ---------------
		public Form1() {
			InitializeComponent();
			SetAddRemoveProgramsIcon();
		}

		private void Form1_Load( object sender, EventArgs e ) {
			FetchEmpDetails();
		}
		//--------------- </ region Form1 > ---------------
		#endregion

		#region Functions
		//--------------- < region Funtions > ---------------
		private void FetchEmpDetails() {
			//Load/Read Data from database
			using ( SqlConnection con = new SqlConnection( connectionStringConfig ) )
			using ( SqlCommand sqlCmd = new SqlCommand( "spCRUD_Operations", con ) ) {
				try {
					con.Open();
					DataTable dt = new DataTable();
					sqlCmd.CommandType = CommandType.StoredProcedure;
					sqlCmd.Parameters.AddWithValue( "@action_type", "ReadData" );
					sqlCmd.Connection = con;
					SqlDataAdapter sqlSda = new SqlDataAdapter( sqlCmd );
					sqlSda.Fill( dt );

					dgvEmp.AutoGenerateColumns = false;//if true displays all the records in the database

					// The property names are the table fields
					dgvEmp.Columns[ 0 ].DataPropertyName = "employee_id"; // This is Employee Id at the datagridview
					dgvEmp.Columns[ 1 ].DataPropertyName = "employee_name";
					dgvEmp.Columns[ 2 ].DataPropertyName = "city";
					dgvEmp.Columns[ 3 ].DataPropertyName = "department";
					dgvEmp.Columns[ 4 ].DataPropertyName = "gender";
					dgvEmp.DataSource = dt;
				} catch ( Exception ex ) {
					MessageBox.Show( "Error: " + ex.Message );
				}
			}
		}

		private void RefreshData() {
			btnSave.Text = "Save";
			textBoxEmp1.Text = "";
			textBoxCity1.Text = "";
			textBoxDept1.Text = "";
			comboBoxGen1.SelectedIndex = -1;
			comboBoxGen1.Text = "";
			EmployeeId = "";
			btnDelete.Enabled = false;
			FetchEmpDetails();
		}

		private void SetAddRemoveProgramsIcon() {
			//This Icon is seen in control panel (uninstalling the app)
			if ( ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.IsFirstRun ) {
				try {
					//The icon located in: (Right click Project -> Properties -> Application (tab) -> Icon)
					var iconSourcePath = Path.Combine( Application.StartupPath, "briefcase-4-fill.ico" );

					if ( !File.Exists( iconSourcePath ) )
						return;

					var myUninstallKey = Registry.CurrentUser.OpenSubKey( @"Software\Microsoft\Windows\CurrentVersion\Uninstall" );
					if ( myUninstallKey == null )
						return;

					var mySubKeyNames = myUninstallKey.GetSubKeyNames();
					foreach ( var subkeyName in mySubKeyNames ) {
						var myKey = myUninstallKey.OpenSubKey( subkeyName, true );
						var myValue = myKey.GetValue( "DisplayName" );
						if ( myValue != null && myValue.ToString() == "SP CRUD" ) { // same as in 'Product name:' field (Located in: Right click Project -> Properties -> Publish (tab) -> Options -> Description)
							myKey.SetValue( "DisplayIcon", iconSourcePath );
							break;
						}
					}
				} catch ( Exception ex ) {
					MessageBox.Show( "Error: " + ex.Message );
				}
			}
		}
		//--------------- </ region Funtions > ---------------
		#endregion

		#region Save/Update and Delete
		//--------------- < region Save/Update and Delete > ---------------
		private void btnSave_Click( object sender, EventArgs e ) {
			//Save or Update btn
			if ( string.IsNullOrWhiteSpace( textBoxEmp1.Text ) ) {
				MessageBox.Show( "Enter Employee Name !!!" );
			} else if ( string.IsNullOrWhiteSpace( textBoxCity1.Text ) ) {
				MessageBox.Show( "Enter Current City !!!" );
			} else if ( string.IsNullOrWhiteSpace( textBoxDept1.Text ) ) {
				MessageBox.Show( "Enter Department !!!" );
			} else if ( comboBoxGen1.SelectedIndex <= -1 ) {
				MessageBox.Show( "Select Gender !!!" );
			} else {

				/*  @employee_id INT = NULL,  
    @employee_name NVARCHAR (250) = NULL,  
    @city NVARCHAR(20) = NULL,  
    @department NVARCHAR(20) = NULL,  
    @gender NVARCHAR(6) = NULL,  
    --@Initialemployee_name NVARCHAR(25) = NULL,  
    @action_type NVARCHAR(25)
				 */
				using ( SqlConnection con = new SqlConnection( connectionStringConfig ) )
				using ( SqlCommand sqlCmd = new SqlCommand( "spCRUD_Operations", con ) ) {
					try {
						con.Open();
						sqlCmd.CommandType = CommandType.StoredProcedure;
						sqlCmd.Parameters.AddWithValue( "@employee_id", EmployeeId );
						sqlCmd.Parameters.AddWithValue( "@employee_name", textBoxEmp1.Text );
						sqlCmd.Parameters.AddWithValue( "@city", textBoxCity1.Text );
						sqlCmd.Parameters.AddWithValue( "@department", textBoxDept1.Text );
						sqlCmd.Parameters.AddWithValue( "@gender", comboBoxGen1.Text );
						sqlCmd.Parameters.AddWithValue( "@action_type", "CreateOrUpdateData" );
						int numRes = sqlCmd.ExecuteNonQuery();
						string ActionType = ( btnSave.Text == "Save" ) ? "Saved" : "Updated";
						if ( numRes > 0 ) {
							MessageBox.Show( $"Record {ActionType} Successfully !!!" );
							RefreshData();
						} else
							MessageBox.Show( $"{textBoxEmp1.Text} Already Exist !!!" );
					} catch ( SqlException ex ) {
						//To always have a guaranteed "Unique Value" in sql: Use UNIQUE CONSTRAINT or Primary Key
						if ( ex.Number == 2627 )  // Violation of unique constraint (Name should be unique)
							MessageBox.Show( $"{textBoxEmp1.Text} Already Exist !!!" );
					} catch ( Exception ex ) {
						MessageBox.Show( "Error: " + ex.Message );
					}
				}
			}
		}

		private void btnDelete_Click( object sender, EventArgs e ) {
			int selectedRowCount = dgvEmp.Rows.GetRowCount( DataGridViewElementStates.Selected );
			if ( selectedRowCount >= 0 ) {
				using ( SqlConnection con = new SqlConnection( connectionStringConfig ) )
				using ( SqlCommand sqlCmd = new SqlCommand( "spCRUD_Operations", con ) ) {
					try {
						con.Open();
						sqlCmd.CommandType = CommandType.StoredProcedure;
						sqlCmd.Parameters.AddWithValue( "@action_type", "DeleteData" );
						sqlCmd.Parameters.AddWithValue( "@employee_id", EmployeeId );
						sqlCmd.ExecuteNonQuery();
						MessageBox.Show( "Record Deleted Successfully !!!" );
						RefreshData();
					} catch ( Exception ex ) {
						MessageBox.Show( "Error: " + ex.Message );
					}
				}
			} else {
				MessageBox.Show( "Please Select A Record !!!" );
			}
			/*  DELETE ALL RECORDS
				using ( SqlConnection con = new SqlConnection( connectionStringConfig ) ) {
				con.Open();
				string query = "TRUNCATE TABLE tblEmployee";
				SqlCommand sqlCmd = new SqlCommand( query, con );
				sqlCmd.ExecuteNonQuery();
				con.Close();
				RefreshData();
			}*/
		}
		//--------------- </ region Save/Update and Delete > ---------------
		#endregion

		private void btnRefresh_Click( object sender, EventArgs e ) {
			RefreshData();
		}

		private void dgvEmp_CellClick( object sender, DataGridViewCellEventArgs e ) {
			if ( e.RowIndex != -1 ) {
				DataGridViewRow row = dgvEmp.Rows[ e.RowIndex ];
				//the ? new .Value would assign null to the Text property of the textboxes in case the cell value is null 
				EmployeeId = row.Cells[ 0 ].Value?.ToString(); //The Employee ID is determined here
				textBoxEmp1.Text = row.Cells[ 1 ].Value?.ToString();
				textBoxCity1.Text = row.Cells[ 2 ].Value?.ToString();
				textBoxDept1.Text = row.Cells[ 3 ].Value?.ToString();
				comboBoxGen1.Text = row.Cells[ 4 ].Value?.ToString();
				btnSave.Text = "Update";
				btnDelete.Enabled = true;
			}
		}

		private void dgvEmp_CellFormatting( object sender, DataGridViewCellFormattingEventArgs e ) {
			//display encrypted value of "Name" column (for non-admin)  with decryptbypassphrase
			//dgv.Cells[ 1 ].Value.GetType() is typeof( System.Int16 )
			/* if ( dgvEmp.Rows.Count == 0 && e.ColumnIndex == 1 && dgvEmp[ 0, 1 ].ValueType == typeof( string ) ) {
                 if ( e.Value != null ) {
                     byte[] array = ( byte[] ) e.Value;
                     e.Value = BitConverter.ToString( array );
                     e.FormattingApplied = true;
                 } else
                     e.FormattingApplied = false;
             }*/
		}
	}
}
