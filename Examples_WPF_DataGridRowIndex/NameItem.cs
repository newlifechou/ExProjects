using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_WPF_DataGridRowIndex
{
    /// <summary>
    /// 对现有对象外面再包裹一层,增加个index字段专门用来显示序号.
    /// </summary>
    public class NameItem
    {
        public int Index { get; set; }
        public string Name { get; set; }
    }
}
