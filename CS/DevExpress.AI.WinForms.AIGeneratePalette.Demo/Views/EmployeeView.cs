using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.AI.WinForms.AIGeneratePalette.Demo.Model;
using DevExpress.XtraEditors;

namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo.Views {
    public partial class EmployeeView : XtraUserControl {
        public EmployeeView() {
            InitializeComponent();
            StatusImageComboBoxEdit.Properties.Items.AddEnum<EmployeeStatus>();
            EditorHelpers.CreatePersonPrefixImageComboBox(PrefixImageComboBoxEdit.Properties, null);
            colPriority.ColumnEdit = EditorHelpers.CreateTaskPriorityImageComboBox(null, gridControlTasks.RepositoryItems);
            DepartmentImageComboBoxEdit.Properties.Items.AddEnum<EmployeeDepartment>();
            StateImageComboBoxEdit.Properties.Items.AddEnum<StateEnum>();
            this.bindingSource.Add(EmployeeDataHelper.CreateDefaultEmployee());
        }
    }
}
