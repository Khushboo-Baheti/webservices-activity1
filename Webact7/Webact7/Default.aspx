<%@ Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webact7._Default" %>

<!DOCTYPE html>
<html>
<body>
<form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" OnLoad="UpdatePanel1_Load ">
            <ContentTemplate>
                <fieldset>
                    <legend>Update Day & Text</legend>
                    <asp:Timer ID="Timer1" runat="server" Interval="500" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <asp:Label ID="year1" runat="server" Text="year"></asp:Label>
                    </br>
                    <asp:Label ID="text1" runat="server" Text="text"></asp:Label>
                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
    <p>
            <strong><span class="auto-style1">Math Trivia ...</span></strong></p>
        <p>
            Question:
            <asp:Label ID="trivia_question" runat="server" ></asp:Label>
        </p>
        <p>
            What is your answer:
            <asp:TextBox ID="trivia_answer" runat="server"></asp:TextBox>
            <asp:Button ID="trivia_submit" runat="server" OnClick="trivia_submit_Click" Text="Check your answer!" />
        </p>
        <p>
            <asp:Label ID="trivia_checkanswer" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="trivia_canswer" runat="server" Visible="False" ></asp:Label>
        </p>
        <p> ______________________________________________________________________________________________________________</p>

            <p><strong><span class="auto-style1">Sentiment Analysis ...</span></strong></p>
        <p>
            Enter your text string:
            <asp:TextBox ID="sentiment_text" runat="server"></asp:TextBox>
            <asp:Button ID="sentiment_submit" runat="server" OnClick="sentiment_submit_Click" Text="Analyze text!" />
        </p>
        <p>
            <asp:Label ID="sentiment_answer" runat="server"></asp:Label>
        </p>
        <p>
            ________________________________________________________________________________________________________________________________________</p>
        <p>
            <strong><span class="auto-style1">Currency Converter ... Please enter the Capital letters only.</span></strong></p>
        <p>
            From:
            rom" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; To:
            <asp:TextBox ID="convert_to" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="convert_submit" runat="server" OnClick="convert_submit_Click" Text="convert" />
        </p>
        <p>
            <asp:Label ID="convert_rate" runat="server"></asp:Label>
        </p>

</form>
    </body>
    </html>
