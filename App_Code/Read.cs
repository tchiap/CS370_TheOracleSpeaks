using System;
using System.Data;
using System.Configuration;
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
/// Read.cs
/// Thomas J. Chiapete
/// </summary>
public class Read
{
    // Class variables, data members
    public static ArrayList predictList; // Declare ArrayList to store list of responses
    public static int random; // All important static random variable

    // Constant holding location of PredictFile.txt
    public const string PATH = "C:\\Documents and Settings\\Tom\\My Documents\\"
                                    +"Visual Studio 2008\\WebSites\\TheOracleSpeaks\\";

    public Read()
    {
    }

    /**
     * GetAnswer() method
     * Retreives an answer from the array based on what is 
     * stored in the static variable random
     */
    public static String GetAnswer(int rand)
    {
        // Set argument variable rand to static data member random
        random = rand;
        
        // Sleep for 3 seconds.  The delay will make conditions more 
        // favorable for bashing.
        Thread.Sleep(3000);
        
        // Retrieve the object stored in predictList at index random (static variable)
        string answer = (string)predictList[random];
        
        // Return result -- back to form
        return answer;
    }

    /**
     * FillAnswers() method
     * Fills in the ArrayList predictList with the answers to questions provided by the user.
     */
    public static void FillAnswers()
    {

        // Initialize list
        string line = "";
        predictList = new ArrayList();

        // Read in file
        System.IO.StreamReader file = 
            new System.IO.StreamReader(PATH + "data\\PredictFile.txt");
        while ((line = file.ReadLine()) != null)
        {
            // For each line (answer), add it to the ArrayList
            predictList.Add((string)line);
        }
        // Close when finished
        file.Close();
    }
}
