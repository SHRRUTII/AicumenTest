using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AicumenTest
{
    /// <summary>
    /// Dashboard MenuItem model
    /// </summary>
    public class DashboardPageMenuItem
    {
        public DashboardPageMenuItem()
        {
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}