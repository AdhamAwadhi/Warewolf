﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Warewolf.Studio.UISpecs.Tools.Database
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UITesting.CodedUITestAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
    public partial class MySqlConnectorFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MySqlConnector.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MySqlConnector", "\tIn order to manage my database services\r\n\tAs a Warewolf User\r\n\tI want to be show" +
                    "n the database service setup", ProgrammingLanguage.CSharp, new string[] {
                        "Ignore"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "MySqlConnector")))
            {
                Warewolf.Studio.UISpecs.Tools.Database.MySqlConnectorFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Drag toolbox MySql Tool onto a new workflow creates MySql tool with large view on" +
            " the design surface")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MySqlConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("NeedsBlankWorkflow")]
        public virtual void DragToolboxMySqlToolOntoANewWorkflowCreatesMySqlToolWithLargeViewOnTheDesignSurface()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Drag toolbox MySql Tool onto a new workflow creates MySql tool with large view on" +
                    " the design surface", new string[] {
                        "NeedsBlankWorkflow"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.When("I \"Drag_Toolbox_MySql_Database_Onto_DesignSurface\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I \"Assert_Mysql_Database_Large_View_Exists_OnDesignSurface\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("I \"Open_MySql_Database_Tool_Small_View\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("I \"Assert_Mysql_Database_Large_View_Exists_OnDesignSurface\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Creating MySQL Connector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MySqlConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void CreatingMySQLConnector()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating MySQL Connector", new string[] {
                        "ignore"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("I open New Workflow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.Then("\"New Workflow\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.And("\"Source\" is focused", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("\"Source\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("\"Action\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("\"Inputs/Outputs\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("\"Mapping\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("I Select \"mysqlSource\" as Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("\"Action\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.When("I select new_procedure as the action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("\"Inputs/Outputs\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.And("\"Validate\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.When("I click \"Validate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("the \"Test Connector and Calculate Outputs\" window is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.And("I click \"Test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "value"});
            table1.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table1.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table1.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table1.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table1.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table1.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table1.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table1.AddRow(new string[] {
                        "1212",
                        "ffff"});
#line 40
 testRunner.Then("Outputs appear as", ((string)(null)), table1, "Then ");
#line 50
 testRunner.When("I click \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table2.AddRow(new string[] {
                        "ID",
                        "[[new_procedure().id]]"});
            table2.AddRow(new string[] {
                        "value",
                        "[[new_procedure().value]]"});
#line 51
 testRunner.And("mappings are", ((string)(null)), table2, "And ");
#line 55
 testRunner.And("\"Recordset Name\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.When("the MySql Connector tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.And("the execution has \"No\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table3.AddRow(new string[] {
                        "[[new_procedure().id]] = 1212"});
            table3.AddRow(new string[] {
                        "[[new_procedure().value]] = ffff"});
#line 58
 testRunner.Then("the debug output as", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opening Saved workflow with MySQL Connector tool")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MySqlConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void OpeningSavedWorkflowWithMySQLConnectorTool()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opening Saved workflow with MySQL Connector tool", new string[] {
                        "ignore"});
#line 64
this.ScenarioSetup(scenarioInfo);
#line 65
   testRunner.Given("I open MySql_workflow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 66
 testRunner.Then("\"MySql_workflow\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.And("\"Source\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("\"Source\" equals \"mysqlSource\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("\"Action\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("\"Action\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("\"Input/Output\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Inputs",
                        "Value",
                        "Empty is Null"});
#line 72
 testRunner.And("input mappings are", ((string)(null)), table4, "And ");
#line 74
 testRunner.And("\"Validate\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("\"Mapping\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table5.AddRow(new string[] {
                        "id",
                        "[[new_procedure().id]]"});
            table5.AddRow(new string[] {
                        "value",
                        "[[new_procedure().value]]"});
#line 76
 testRunner.And("mappings are", ((string)(null)), table5, "And ");
#line 80
 testRunner.And("\"Recordset Name\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change MySQL Source on Existing tool")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MySqlConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void ChangeMySQLSourceOnExistingTool()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change MySQL Source on Existing tool", new string[] {
                        "ignore"});
#line 83
this.ScenarioSetup(scenarioInfo);
#line 84
 testRunner.Given("I open MySql_workflow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
 testRunner.Then("\"MySql_workflow\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.And("\"Source\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("\"Source\" equals \"mysqlSource\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("\"Action\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("\"Action\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("\"Input/Output\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Inputs",
                        "Value",
                        "Empty is Null"});
#line 91
 testRunner.And("input mappings are", ((string)(null)), table6, "And ");
#line 93
 testRunner.And("\"Validate\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("\"Mapping\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table7.AddRow(new string[] {
                        "id",
                        "[[new_procedure().id]]"});
            table7.AddRow(new string[] {
                        "value",
                        "[[new_procedure().value]]"});
#line 95
 testRunner.And("mappings are", ((string)(null)), table7, "And ");
#line 99
 testRunner.And("\"Recordset Name\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.When("\"Source\" is changed from \"mysqlSource\" to \"TestMysql\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.Then("\"Action\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.And("\"Inputs/Outputs\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("\"Mapping\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("\"Validate\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing MySql Connector and Test Execution is unsuccesful")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MySqlConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void EditingMySqlConnectorAndTestExecutionIsUnsuccesful()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing MySql Connector and Test Execution is unsuccesful", new string[] {
                        "ignore"});
#line 108
 this.ScenarioSetup(scenarioInfo);
#line 109
   testRunner.Given("I open \"MySql_workflow\" service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 110
   testRunner.And("\"MySql_workflow\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
   testRunner.Then("\"1 Data Source\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
   testRunner.And("Data Source is focused", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
   testRunner.When("\"DemoDB\" is selected as the data source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
   testRunner.Then("\"2 Select Action\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
   testRunner.And("\"dbo.InsertDummyUser\" is selected as the action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
   testRunner.Then("\"3 Test Connector and Calculate Outputs\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
   testRunner.And("Inspect Data Connector hyper link is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "fname",
                        "lname",
                        "username",
                        "password",
                        "lastAccessDate"});
            table8.AddRow(new string[] {
                        "Change",
                        "Test",
                        "wolf",
                        "Dev",
                        "10/1/1990"});
#line 118
   testRunner.And("inputs are", ((string)(null)), table8, "And ");
#line 121
   testRunner.And("\"Test\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
   testRunner.And("\"Save\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
   testRunner.When("testing the action fails", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
   testRunner.Then("\"4 Defaults and Mapping\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Inputs",
                        "Default Value",
                        "Required Field",
                        "Empty is Null"});
#line 125
   testRunner.And("input mappings are", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Output",
                        "Output Alias",
                        "Recordset Name"});
#line 127
 testRunner.And("output mappings are", ((string)(null)), table10, "And ");
#line 129
 testRunner.And("\"Save\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Changing MySQL Actions")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MySqlConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void ChangingMySQLActions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Changing MySQL Actions", new string[] {
                        "ignore"});
#line 132
this.ScenarioSetup(scenarioInfo);
#line 133
 testRunner.Given("I open MySql_workflow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 134
 testRunner.Then("\"MySql_workflow\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.And("\"Source\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("\"Source\" equals \"mysqlSource\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("\"Action\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("\"Action\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("\"Input/Output\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Inputs",
                        "Value",
                        "Empty is Null"});
#line 140
 testRunner.And("\"Input/Output\" mappings are", ((string)(null)), table11, "And ");
#line 142
 testRunner.And("\"Validate\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.And("\"Mapping\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table12.AddRow(new string[] {
                        "id",
                        "[[new_procedure().id]]"});
            table12.AddRow(new string[] {
                        "value",
                        "[[new_procedure().value]]"});
#line 144
 testRunner.And("mappings are", ((string)(null)), table12, "And ");
#line 148
 testRunner.When("\"Action\" is changed from \"new_procedure\" to \"getCountries\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.Then("\"Inputs/Outputs\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
 testRunner.And("\"Mapping\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
 testRunner.And("\"Validate\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Value",
                        "Empty is Null"});
#line 152
 testRunner.And("\"Inputs/Outputs\" appear as", ((string)(null)), table13, "And ");
#line 154
 testRunner.When("I click \"Validate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 155
 testRunner.Then("the \"Test Connector and Calculate Outputs\" window is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 156
 testRunner.And("I click \"Test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "value"});
            table14.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table14.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table14.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table14.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table14.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table14.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table14.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table14.AddRow(new string[] {
                        "1212",
                        "ffff"});
#line 157
 testRunner.Then("Outputs appear as", ((string)(null)), table14, "Then ");
#line 167
 testRunner.When("I click \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table15.AddRow(new string[] {
                        "ID",
                        "[[new_procedure().id]]"});
            table15.AddRow(new string[] {
                        "value",
                        "[[new_procedure().value]]"});
#line 168
 testRunner.And("mappings are", ((string)(null)), table15, "And ");
#line 172
 testRunner.And("\"Recordset Name\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change MySQL Recordset Name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MySqlConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void ChangeMySQLRecordsetName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change MySQL Recordset Name", new string[] {
                        "ignore"});
#line 175
this.ScenarioSetup(scenarioInfo);
#line 176
 testRunner.Given("I open MySql_workflow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 177
 testRunner.Then("\"MySql_workflow\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 178
 testRunner.And("\"Source\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
 testRunner.And("\"Source\" equals \"mysqlSource\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 180
 testRunner.And("\"Action\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.And("\"Action\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
 testRunner.And("\"Input/Output\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Value",
                        "Empty is Null"});
#line 183
 testRunner.And("\"Inputs/Outputs\" appear as", ((string)(null)), table16, "And ");
#line 185
 testRunner.When("I click \"Validate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 186
 testRunner.Then("the \"Test Connector and Calculate Outputs\" window is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 187
 testRunner.And("I click \"Test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
 testRunner.And("\"Mapping\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 189
 testRunner.When("I test the action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "value"});
            table17.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table17.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table17.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table17.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table17.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table17.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table17.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table17.AddRow(new string[] {
                        "1212",
                        "ffff"});
#line 190
 testRunner.And("Outputs appear as", ((string)(null)), table17, "And ");
#line 200
 testRunner.When("I click \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table18.AddRow(new string[] {
                        "ID",
                        "[[new_procedure().id]]"});
            table18.AddRow(new string[] {
                        "value",
                        "[[new_procedure().value]]"});
#line 201
 testRunner.And("mappings are", ((string)(null)), table18, "And ");
#line 205
 testRunner.And("\"Recordset Name\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
 testRunner.When("\"Recordset Name\" is changed from \"new_procedure\" to \"New_Category\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table19.AddRow(new string[] {
                        "id",
                        "[[New_Category().id]]"});
            table19.AddRow(new string[] {
                        "value",
                        "[[New_Category().value]]"});
#line 207
 testRunner.Then("mappings are", ((string)(null)), table19, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invalid Recordset name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MySqlConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void InvalidRecordsetName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invalid Recordset name", new string[] {
                        "ignore"});
#line 213
this.ScenarioSetup(scenarioInfo);
#line 214
 testRunner.Given("I open New Workflow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 215
 testRunner.Then("\"New Workflow\" tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 216
 testRunner.And("\"Source\" is focused", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 217
 testRunner.And("\"Source\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 218
 testRunner.And("\"Action\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 219
 testRunner.And("\"Inputs/Outputs\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 220
 testRunner.And("\"Mapping\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 221
 testRunner.When("I Select \"mysqlSource\" as Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 222
 testRunner.Then("\"Action\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 223
 testRunner.When("I select new_procedure as the action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 224
 testRunner.Then("\"Inputs/Outputs\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 225
 testRunner.And("\"Validate\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Value",
                        "Empty is Null"});
#line 226
 testRunner.And("\"Inputs/Outputs\" appear as", ((string)(null)), table20, "And ");
#line 228
 testRunner.When("I click \"Validate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 229
 testRunner.Then("the \"Test Connector and Calculate Outputs\" window is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 230
 testRunner.And("I click \"Test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 231
 testRunner.And("\"Mapping\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 232
 testRunner.When("I test the action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "value"});
            table21.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table21.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table21.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table21.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table21.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table21.AddRow(new string[] {
                        "1212",
                        "ffff"});
            table21.AddRow(new string[] {
                        "123123123",
                        "aasdasdasdasd"});
            table21.AddRow(new string[] {
                        "1212",
                        "ffff"});
#line 233
 testRunner.And("Outputs appear as", ((string)(null)), table21, "And ");
#line 243
 testRunner.When("I click \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table22.AddRow(new string[] {
                        "ID",
                        "[[new_procedure().id]]"});
            table22.AddRow(new string[] {
                        "value",
                        "[[new_procedure().value]]"});
#line 244
 testRunner.And("mappings are", ((string)(null)), table22, "And ");
#line 248
 testRunner.And("\"Recordset Name\" equals \"new_procedure\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 249
 testRunner.When("\"Recordset Name\" is changed from \"new_procedure\" to \"#$New_Category\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 250
 testRunner.When("the MySql Connector tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 251
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table23.AddRow(new string[] {
                        "Error : input must be recordset or value"});
#line 252
 testRunner.Then("the debug output as", ((string)(null)), table23, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
