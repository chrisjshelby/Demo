using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo.WebApp.Controls
{
    [ToolboxData("<{0}:CSVExport runat=server></{0}:CSVExport>")]
    public class CSVExport : WebControl
    {
        private List<Data.Entities.Contact> contacts;

        [Bindable(true)]
        [Category("Data")]
        [Description("The list of contacts to export.")]
        public List<Data.Entities.Contact> Contacts
        {
            get { return contacts; }
            set { contacts = value ?? new List<Data.Entities.Contact>(); }
        }

        public CSVExport()
        {
           
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            Controls.Clear();
            var exportButton = new Button
            {
                Text = "Export to CSV",
                CssClass = "btn btn-secondary",
                OnClientClick = "return confirm('Are you sure you want to export the data?');",
                CausesValidation = false
            };
            exportButton.Click += ExportButton_Click;
            Controls.Add(exportButton);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var lines = new List<string>();
            foreach (var c in contacts)
            {
                lines.Add($"{c.ID} {c.LastName}, {c.FirstName} {c.MainPhone}");
                if (!string.IsNullOrWhiteSpace(c.AlternatePhone) && c.MainPhone != c.AlternatePhone)
                {
                    lines.Add($"{c.ID} {c.LastName}, {c.FirstName} {c.AlternatePhone}");
                }
            }

            var csv = new StringBuilder();
            foreach (var line in lines)
                csv.AppendLine(line);

            var response = HttpContext.Current.Response;
            response.Clear();
            response.ContentType = "text/csv";
            response.AddHeader("Content-Disposition", "attachment; filename=contacts.csv");
            response.Write(csv.ToString());
            response.Flush();
            response.SuppressContent = true; // Prevent further output
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
    }
}
