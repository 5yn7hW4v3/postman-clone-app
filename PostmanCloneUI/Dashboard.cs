namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void btnAPI_Click(object sender, EventArgs e)
    {
        // Validate API URL


        try
        {
            lblSystemStatus.Text = "Calling API...";

            // Sample code - replace with actual API Call
            await Task.Delay(2000);

            lblSystemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            txtResults.Text = "Error: " + ex.Message;
            lblSystemStatus.Text = "Error";
        }
    }
}
