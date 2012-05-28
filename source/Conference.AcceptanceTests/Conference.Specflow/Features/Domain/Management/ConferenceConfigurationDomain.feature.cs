﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Domain.Management
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsWithEventsAndCommandsFeature : Xunit.IUseFixture<ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsWithEventsAndCommandsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ConferenceConfigurationDomain.feature"
#line hidden
        
        public ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsWithEventsAndCommandsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Conference configuration scenarios for creating and editing Conference settings w" +
                    "ith events and commands", "In order to create or update a Conference configuration\r\nAs a Business Customer\r\n" +
                    "I want to be able to create or update a Conference and set its properties", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsWithEventsAndCommandsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsWithEventsAndCommandsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsWithEventsAndCommandsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
