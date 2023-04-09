using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections;
using System.Threading;

/// <summary>
/// Default.aspx.cs
/// Created by Thomas J. Chiapete
/// </summary>
public partial class _Default : System.Web.UI.Page 
{
    // Instance variables
    public ArrayList sayingsList;
    
    // Constants
    public const string PATH = "C:\\Documents and Settings\\Tom\\My Documents\\"
                                    +"Visual Studio 2008\\WebSites\\TheOracleSpeaks\\";

    /**
     * Page_Load method.  Upon page load, initialize the sayingsList to an ArrayList,
     * fill in the ArrayList with Sayings.  Do the same for predictList, which is 
     * found in the Read class.
     */
    protected void Page_Load(object sender, EventArgs e)
    {

        // Set alert flag to false.  This will show true when bashing occurs.
        lblBashing.Visible = false;

        // Initialize sayingsList.
        sayingsList = new ArrayList();

        // Read in file.
        string line = "";
        System.IO.StreamReader file = 
            new System.IO.StreamReader(PATH + "data\\SayingsFile.txt");
        while ((line = file.ReadLine()) != null)
        {
            // For every line, add a saying
            sayingsList.Add((string)line);
        }
        // Close the file when finished.
        file.Close();

        // Method call to logic to fill in predictArray.
        Read.FillAnswers();        
    }

    /**
     * btnGetSaying_Click() method
     * On clicking of Get Saying, retrieve a random saying from file.
     */
    protected void btnGetSaying_Click(object sender, EventArgs e)
    {
        Random rand = new Random();    // Create Random object  
   
        // First, create a random number between 0 and the size of the sayingsList 
        // minus 1.  This is because the ArrayList is referenced just like an Array.
        // Next, retrieve the object at the position of the number that was generated.
        // Lastly, cast it to string from object so we can send it back to the page.
        lblSaying.Text = (string)sayingsList[rand.Next(0, sayingsList.Count - 1)];
    }

    /**
     * btnGetFortune_Click() method
     * On clicking of "Ask Me!" button, retrieve a random fortune from file.
     * This example will prove the existance of a shared variable being 
     * overwritten in another class.
     */
    protected void btnGetFortune_Click(object sender, EventArgs e)
    {
        Random r = new Random(); // Create a Random object

        // Generate a random number between zero and the predictList size minus 1.
        int rand = r.Next(0, Read.predictList.Count - 1);
        
        // Output.  First, output our local random number, plus 1.  This is so 
        // regular users can see which position it's in starting from 1, not 0.
        // Next, call GetAnswer() by passing our local random number as the parameter.
        lblAnswerToQuestion.Text = (rand+1) + ". " + Read.GetAnswer(rand);

        // Based on how our Read class is set up, we can test to see if bashing occurs,
        // a shared variable is overwritten.  If the local number doesn't match the 
        // shared value, we have bashing.  Set the visible property to true then.
        // This is set to invisible at Form_Load.
        if ( rand != Read.random)
            lblBashing.Visible = true;
    }
}
