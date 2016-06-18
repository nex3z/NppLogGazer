using NppLogGazer.Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.Common.Utility
{
    public static class ExceptionMessageUtility
    {
        public static string BuildLoadDataExceptionMessage(LoadDataException ex)
        {
            string message = Properties.Resources.ex_msg_error_reading_default_config + ex.Message;
            if (ex.BackupInfo != null && ex.BackupInfo != string.Empty)
            {
                message += Properties.Resources.ex_msg_backup_at + ex.BackupInfo;
            }
            return message;
        }
    }
}
