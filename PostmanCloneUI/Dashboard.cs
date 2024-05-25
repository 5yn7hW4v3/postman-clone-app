using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
    }

    private async void btnAPI_Click(object sender, EventArgs e)
    {
        lblSystemStatus.Text = "Calling API...";
        txtResults.Text = "";

        // Validate API URL
        if (api.IsValidUrl(txtAPI.Text) == false)
        {
            lblSystemStatus.Text = "Invalid URL";
            return;
        }

        try
        {
            lblSystemStatus.Text = "Calling API...";

            txtResults.Text = await api.CallApi(txtAPI.Text);

            lblSystemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            txtResults.Text = "Error: " + ex.Message;
            lblSystemStatus.Text = "Error";
        }
    }
}
