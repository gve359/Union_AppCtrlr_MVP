using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Project.GUI;
using Project.DataSource;
using Project.GUI.Widgets.ChartRealtime;


namespace Project.ClassRelations
{
    public class Relation__ChartRealTime_Server
    {
        private AChartRealtime chart;
        private IServerClass server;

        public Relation__ChartRealTime_Server(AChartRealtime chart, IServerClass server)
        {
            this.chart = chart;
            this.server = server;

            this.server.TableUpdated += OnTableUpdated;
            this.chart.Disposed += Destroy;
        }
        
        private void OnTableUpdated(DataTable table)
        {
            this.chart.SetTable(table);
        }

        private void Destroy(object sender, EventArgs e)
        {
            this.server.TableUpdated -= OnTableUpdated;
            this.chart.Disposed -= Destroy;
        }

    }
}
