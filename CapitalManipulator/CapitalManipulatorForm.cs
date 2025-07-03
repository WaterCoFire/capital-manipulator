namespace CapitalManipulator;

public partial class CapitalManipulatorForm : Form {
    public CapitalManipulatorForm() {
        InitializeComponent();
    }

    /// <summary>
    /// Start
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CapitalManipulatorForm_Load(object sender, EventArgs e) {
        // throw new System.NotImplementedException();
    }

    private void prompt_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void author_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void manipulateButton_Click(object sender, EventArgs e) {
        ManipulationManager.ExecuteRandomPrank(this);
    }
}