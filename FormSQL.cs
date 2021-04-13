using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCopyTool
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private void radioDBUser_CheckedChanged(object sender, EventArgs e)
        {
            labelSQLQuery.Text = "DB User Update";
            textBoxSQL.Text = "EXEC Sp_change_users_login 'update_one', '<" + textDBUser.Text.Trim() + ">', '<" + textDBUser.Text.Trim() + ">'";
            labelClipSuccess.Text = "";
        }

        private void dBUserName_TextChanged(object sender, EventArgs e)
        {
            //textBoxSQL.Text = "EXEC Sp_change_users_login 'update_one', '<" + textDBUser.Text + ">', '<" + textDBUser.Text + ">'";
        }

        private void radioClearScript_CheckedChanged(object sender, EventArgs e)
        {
            labelSQLQuery.Text = "Clear Script";
            textBoxSQL.Text = "--Run the following scripts against the Destination database AFTER the Restore\r\n\r\nUPDATE tdc_sys_user\r\nSET mailbox = '' --removes Email addresses from Users\r\nDELETE FROM tdc_sys_messages --Clears pending messages in database\r\nDELETE FROM tdc_publish_queue --Clears out the publishing queue\r\nDELETE FROM list_sorting -- resets users preferences to default for list views\r\nDELETE FROM web_sessions  -- Clears users that were logged in";
            labelClipSuccess.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            radioDBUser.Checked = true;
            labelSQLQuery.Text = "DB User Update - Updated Successfully";
            textBoxSQL.Text = "EXEC Sp_change_users_login 'update_one', '" + textDBUser.Text.Trim() + "', '" + textDBUser.Text.Trim() + "'";
            labelClipSuccess.Text = "";
        }

        private void radioGetSys_CheckedChanged(object sender, EventArgs e)
        {
            labelSQLQuery.Text = "Get Sysadmin Pin and Approval Pin";
            textBoxSQL.Text = "--Get the pin and approve pin and save for later to change back\r\n\r\nSELECT user_name, pin as SaveThisPinForLater, approve_pin as SaveApprovePinForLater\r\nFROM tdc_sys_user\r\nWHERE user_id = 'sysadmin'";
            labelClipSuccess.Text = "";
        }

        private void radioSetSys_CheckedChanged(object sender, EventArgs e)
        {
            labelSQLQuery.Text = "Set Sysadmin Pin and Approval Pin";
            textBoxSQL.Text = "-- Updates Pin and Approval Pin to Sysadmin\r\n-- IMPORTANT: Remember to change values back to original at the end.\r\n\r\nUPDATE tdc_sys_user\r\nSET pin = '" + textBoxPin.Text.Trim() + "'\r\nWHERE user_id = 'sysadmin'\r\n\r\nUPDATE tdc_sys_user\r\nSET approve_pin = '" + textBoxAppPin.Text.Trim() + "'\r\nWHERE user_id = 'sysadmin'";
            labelClipSuccess.Text = "";
        }

        private void buttonUpdatePins_Click(object sender, EventArgs e)
        {
            radioSetSys.Checked = true;
            labelSQLQuery.Text = "Set Sysadmin Pin and Approval Pin - Updated Successfully";
            textBoxSQL.Text = "-- Updates Pin and Approval Pin to Sysadmin\r\n-- IMPORTANT: Remember to change values back to original at the end.\r\n\r\nUPDATE tdc_sys_user\r\nSET pin = '" + textBoxPin.Text.Trim() + "'\r\nWHERE user_id = 'sysadmin'\r\n\r\nUPDATE tdc_sys_user\r\nSET approve_pin = '" + textBoxAppPin.Text.Trim() + "'\r\nWHERE user_id = 'sysadmin'";
            labelClipSuccess.Text = "";
        }

        private void radioCheckDS_CheckedChanged(object sender, EventArgs e)
        {
            labelSQLQuery.Text = "Check for External DataStructures";
            textBoxSQL.Text = "--Determine if there are external data structures\r\n-- Note if there are results, then there are external data structures\r\n\r\nSELECT name, sourceconfig\r\nFROM web_data_structure\r\nwhere ds_type = 1";
            labelClipSuccess.Text = "";
        }

        private void radioGetDS_CheckedChanged(object sender, EventArgs e)
        {
            labelSQLQuery.Text = "External Data Structures: GET Old and New";
            textBoxSQL.Text = "-- Use these two scripts to get OLD and NEW source Configs\r\n\r\nDECLARE @editedds varchar(200)\r\nSET @editedds = '" + textBoxDefaultDS.Text.Trim() + "'  -- <---- Replace with Name of DataStructure edited on Frontend\r\n\r\nSELECT distinct sourceconfig as OLD_SOURCECONFIG\r\nFROM   web_data_structure\r\nWHERE ds_type = 1 and name != @editedds\r\n\r\nSELECT NAME, sourceconfig as NEW_SOURCECONFIG\r\nFROM   web_data_structure\r\nWHERE  name= @editedds";
            labelClipSuccess.Text = "";
        }

        private void radioSetDS_CheckedChanged(object sender, EventArgs e)
        {
            labelSQLQuery.Text = "External Data Structures: SET Old and New";
            textBoxSQL.Text = "-- Replace The \"OLD SOURCE CONFIG\" and the \"NEW SOURCE CONFIG\" with the \"Query Results\"\r\n-- Remember to COMMIT\r\n\r\nBEGIN TRAN\r\n\r\n   DECLARE @newSourceConfig nvarchar(4000)\r\n   DECLARE @oldSoruceConfig nvarchar(4000)\r\n\r\n   SET @oldSoruceConfig='" + textBoxOldConfig.Text.Trim() + "'\r\n   SET @newSourceConfig='" + textBoxNewConfig.Text.Trim() + "'\r\n\r\n   UPDATE web_data_structure\r\n   SET sourceconfig= REPLACE(sourceconfig, @oldSoruceConfig, @newSourceConfig)\r\n   WHERE ds_type=1\r\n\r\n--COMMIT";
            labelClipSuccess.Text = "";
        }

        private void buttonDefaultDS_Click(object sender, EventArgs e)
        {
            radioGetDS.Checked = true;
            labelSQLQuery.Text = "External Data Structures: GET Old and New - Updated Successfully";
            textBoxSQL.Text = "-- Use these two scripts to get OLD and NEW source Configs\r\n\r\nDECLARE @editedds varchar(200)\r\nSET @editedds = '" + textBoxDefaultDS.Text.Trim() + "'  -- <---- Replace with Name of DataStructure edited on Frontend\r\n\r\nSELECT distinct sourceconfig as OLD_SOURCECONFIG\r\nFROM   web_data_structure\r\nWHERE ds_type = 1 and name != @editedds\r\n\r\nSELECT NAME, sourceconfig as NEW_SOURCECONFIG\r\nFROM   web_data_structure\r\nWHERE  name= @editedds";
            labelClipSuccess.Text = "";
        }

        private void buttonReplaceDS_Click(object sender, EventArgs e)
        {
            radioSetDS.Checked = true;
            labelSQLQuery.Text = "External Data Structures: SET Old and New - Updated Successfully";
            textBoxSQL.Text = "-- Replace The \"OLD SOURCE CONFIG\" and the \"NEW SOURCE CONFIG\" with the \"Query Results\"\r\n-- Remember to COMMIT\r\n\r\nBEGIN TRAN\r\n\r\n   DECLARE @newSourceConfig nvarchar(4000)\r\n   DECLARE @oldSoruceConfig nvarchar(4000)\r\n\r\n   SET @oldSoruceConfig='" + textBoxOldConfig.Text.Trim() + "'\r\n   SET @newSourceConfig='" + textBoxNewConfig.Text.Trim() + "'\r\n\r\n   UPDATE web_data_structure\r\n   SET sourceconfig= REPLACE(sourceconfig, @oldSoruceConfig, @newSourceConfig)\r\n   WHERE ds_type=1\r\n\r\n--COMMIT";
            labelClipSuccess.Text = "";
        }

        private void buttonClipboard_Click(object sender, EventArgs e)
        {
            if(textBoxSQL.Text != string.Empty)
            {
                Clipboard.SetText(textBoxSQL.Text);
                labelClipSuccess.Text = "Successfully Copied to Clipboard!";
            }
            else
            {
                labelClipSuccess.Text = "Text box is Empty - Nothing to Copy";
            }
        }
    }
}


