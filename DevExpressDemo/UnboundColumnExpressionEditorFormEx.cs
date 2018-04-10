using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Design;
using System.ComponentModel.Design;
using DevExpress.Data;

namespace DevExpressDemo
{
    public partial class UnboundColumnExpressionEditorFormEx : UnboundColumnExpressionEditorForm
    {
        //构造函数
        public UnboundColumnExpressionEditorFormEx(object contextInstance, IDesignerHost designerHost)
            : base(contextInstance, designerHost)
        {
        }
        //验证的表达式
        public new string Expression
        {
            get { return base.Expression; }
            set { ExpressionMemoEdit.Text = value; }
        }
    }

    //根据实体类反射出列名和列类型
    public class PropertyColumnInfo : IDataColumnInfo
    {
        public PropertyColumnInfo(Type type, string name, bool withChildren = false)
        {
            FieldType = type;
            if (withChildren)
            {
                _columns = new List<IDataColumnInfo>();
                _controllerBase = new DataControllerBase();
                Caption = string.Empty;
            }
            else
            {
                _columns = null;
                _controllerBase = null;
                Caption = name;
            }
            UnboundExpression = string.Empty;
        }
        DataControllerBase _controllerBase = null;
        List<IDataColumnInfo> _columns = null;
        public List<IDataColumnInfo> Columns { get { return _columns; } }
        public DataControllerBase Controller { get { return _controllerBase; } }

        public Type FieldType { get; set; }
        public string Caption { get; private set; }
        public string FieldName { get { return Caption; } }
        public string Name { get { return Caption; } }
        public string UnboundExpression { get; set; }

        public static PropertyColumnInfo FromProperties(Type type)
        {
            PropertyColumnInfo eci = new PropertyColumnInfo(typeof(object), string.Empty, true);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(type);
            foreach (PropertyDescriptor property in properties)
            {
                eci.Columns.Add(new PropertyColumnInfo(property.PropertyType, property.Name));
            }
            return eci;
        }
    }
}