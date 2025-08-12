using Demo.WebApp.Data;
using Demo.WebApp.Data.Entities;
using System;
using System.Web;
using System.Web.UI;

namespace Demo.WebApp
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Request.QueryString["id"] != null)
            {
                int contactId = int.Parse(Request.QueryString["id"]);
                LoadContact(contactId);
            }
        }

        private void LoadContact(int contactId)
        {
            using (var db = new DemoContext())
            {
                var contact = db.Contacts.Find(contactId);
                if (contact != null)
                {
                    txtFirstName.Text = contact.FirstName;
                    txtLastName.Text = contact.LastName;
                    txtEmail.Text = contact.Email;
                    txtPhone.Text = contact.MainPhone;
                    txtAlternatePhone.Text = contact.AlternatePhone;
                }
            }
        }

        protected void AddContactButton_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;

            int contactId;

            try
            {
                using (var db = new DemoContext())
                {
                    Contact contact;
                    if (Request.QueryString["id"] != null)
                    {
                        contactId = int.Parse(Request.QueryString["id"]);
                        contact = db.Contacts.Find(contactId);
                    }
                    else
                    {
                        contact = new Contact();
                        db.Contacts.Add(contact);
                    }
                    contact.FirstName = txtFirstName.Text;
                    contact.LastName = txtLastName.Text;
                    contact.Email = txtEmail.Text;
                    contact.MainPhone = txtPhone.Text;
                    contact.AlternatePhone = txtAlternatePhone.Text;
                    db.SaveChanges();
                    ShowBootstrapAlert("Save Successful!", "Success!", "/");
                }
            }
            catch (Exception error)
            {
                ShowBootstrapAlert("There has been an error, please refresh your broswer try again.", "Error!");
            }
        }

        protected void CancelContactButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/");
        }

        private void ShowBootstrapAlert(string message, string title = "Notice", string redirectUrl = null)
        {
            var msg = HttpUtility.JavaScriptStringEncode(message);
            var ttl = HttpUtility.JavaScriptStringEncode(title);
            var url = string.IsNullOrEmpty(redirectUrl) ? "" : HttpUtility.JavaScriptStringEncode(redirectUrl);

            var script = $@"
                (function() {{
                  var show = function() {{
                    var modalEl = document.getElementById('serverAlertModal');
                    if (!modalEl) return;

                    var msgEl = document.getElementById('serverAlertMessage');
                    var titleEl = modalEl.querySelector('.modal-title');
                    if (msgEl) msgEl.innerText = '{msg}';
                    if (titleEl) titleEl.innerText = '{ttl}';

                    if (window.bootstrap && bootstrap.Modal) {{
                      var modal = bootstrap.Modal.getOrCreateInstance(modalEl);
                      if ('{url}') {{
                        modalEl.addEventListener('hidden.bs.modal', function () {{
                          window.location.href = '{url}';
                        }}, {{ once: true }});
                      }}
                      modal.show();
                    }} else if (window.jQuery && typeof jQuery(modalEl).modal === 'function') {{
                      if ('{url}') {{
                        jQuery(modalEl).on('hidden.bs.modal', function () {{
                          window.location.href = '{url}';
                        }});
                      }}
                      jQuery(modalEl).modal('show');
                    }} else {{
                      console.warn('Bootstrap modal API not found.');
                    }}
                  }};

                  if (window.Sys && Sys.Application) {{
                    Sys.Application.add_load(show);
                  }} else {{
                    window.addEventListener('load', show);
                  }}
                }})();";

            ScriptManager.RegisterStartupScript(this, GetType(), "ShowServerAlertModal", script, true);
        }


    }
}