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
namespace Ejercicio1.spec
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ImportarNotasFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ImportarNotas.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ImportarNotas", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "ImportarNotas")))
            {
                Ejercicio1.spec.ImportarNotasFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Importar Notas al Sistema")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ImportarNotas")]
        public virtual void ImportarNotasAlSistema()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Importar Notas al Sistema", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "AlumnoId",
                        "AlumnoNombre",
                        "MateriaId",
                        "MateriaNombre",
                        "Nota"});
            table1.AddRow(new string[] {
                        "1",
                        "Juan",
                        "1",
                        "Matematicas",
                        "50"});
            table1.AddRow(new string[] {
                        "1",
                        "Juan",
                        "2",
                        "Español",
                        "70"});
            table1.AddRow(new string[] {
                        "1",
                        "Juan",
                        "3",
                        "Quimica",
                        "60"});
            table1.AddRow(new string[] {
                        "2",
                        "Pedro",
                        "1",
                        "Matematicas",
                        "70"});
            table1.AddRow(new string[] {
                        "2",
                        "Pedro",
                        "2",
                        "Español",
                        "90"});
            table1.AddRow(new string[] {
                        "2",
                        "Pedro",
                        "3",
                        "Quimica",
                        "100"});
#line 7
 testRunner.Given("La siguiente hoja electronica", ((string)(null)), table1, "Given ");
#line 15
 testRunner.When("Se importa la data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "AlumnoId",
                        "AlumnoNombre"});
            table2.AddRow(new string[] {
                        "1",
                        "Juan"});
            table2.AddRow(new string[] {
                        "2",
                        "Pedro"});
#line 16
 testRunner.Then("La siguiente informacion se inserto en la tabla Alumno", ((string)(null)), table2, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "MateriaId",
                        "MateriaNombre"});
            table3.AddRow(new string[] {
                        "1",
                        "Matematicas"});
            table3.AddRow(new string[] {
                        "2",
                        "Español"});
            table3.AddRow(new string[] {
                        "3",
                        "Quimica"});
#line 20
 testRunner.And("La siguiente informacion se inserto en la tabla Materia", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "AlumnoId",
                        "MateriaId",
                        "Nota"});
            table4.AddRow(new string[] {
                        "1",
                        "1",
                        "50"});
            table4.AddRow(new string[] {
                        "1",
                        "2",
                        "70"});
            table4.AddRow(new string[] {
                        "1",
                        "3",
                        "60"});
            table4.AddRow(new string[] {
                        "2",
                        "1",
                        "70"});
            table4.AddRow(new string[] {
                        "2",
                        "2",
                        "90"});
            table4.AddRow(new string[] {
                        "2",
                        "3",
                        "100"});
#line 25
 testRunner.And("La siguiente informacion se inserto en la tabla Notas", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion