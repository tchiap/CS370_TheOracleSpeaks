<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>The Oracle Speaks</title>
    <style type="text/css">
        body
        {
            background-color: #000000;
            color: #ffffff;
            font-family: Arial;
        }
        #Question
        {
            width: 300px;
        }
        .style1
        {}
        #GetSaying
        {}
        .style2
        {
            font-size: large;
            font-weight: bold;
        }
    </style>


</head>
<body>
<p>&#160;</p>

    <form id="form1" runat="server">
    <div>
    
    <table summary="" width="100%" style="text-align: center;">
    <tr>
    <td class="style1">
    <asp:Button ID="btnGetSaying" runat="server" 
           Text="Get Saying!" onclick="btnGetSaying_Click" />

    
        <br />
        <br />
        
        <asp:Label ID="lblSaying" runat="server" Text="" />
        <br />
        <br />
        <br />
        <br />
    
    

    
    </td>
    </tr>
    </table>
    
    <table summary="" width="100%" style="text-align: center;">
    <tr>
    <td class="style1">
    
    <br /><br />
    
    <asp:TextBox ID="txtQuestion" runat="server" Width="486px" ></asp:TextBox>
    <br />
        <asp:Button ID="btnGetFortune" runat="server" Text="Ask Me!" 
            onclick="btnGetFortune_Click" />
        <br />
        <br />
        <asp:Label ID="lblAnswerToQuestion" runat="server" Text="" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblBashing" runat="server" Text="&gt;&gt; THREAD BASHING HAS OCCURRED!" 
            style="font-weight: 700; font-size: x-small; background-color: #990000" />
        </td>
    </tr>
    
      </table>
    
    
        
    
    </div>
    </form>
    <p class="style1">
        &nbsp;</p>
</body>
</html>
