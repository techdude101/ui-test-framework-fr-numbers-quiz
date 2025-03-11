﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UiTestFrameworkFrNumbersQuiz.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CardinalNumbers")]
    [NUnit.Framework.FixtureLifeCycleAttribute(NUnit.Framework.LifeCycle.InstancePerTestCase)]
    public partial class CardinalNumbersFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CardinalNumbers", "  As a user,\r\n  I want to take a quiz to test my knowledge of cardinal numbers,\r\n" +
                "  So that I can assess my understanding and improve my skills.", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "CardinalNumbers.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User answers a quiz question correctly and goes to the next question")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public async System.Threading.Tasks.Task UserAnswersAQuizQuestionCorrectlyAndGoesToTheNextQuestion()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("User answers a quiz question correctly and goes to the next question", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 9
 await testRunner.GivenAsync("the quiz is started", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 10
 await testRunner.AndAsync("a question is displayed asking for a cardinal number", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 11
 await testRunner.WhenAsync("the user inputs the correct answer", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 12
 await testRunner.AndAsync("the user clicks on the next question button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 13
 await testRunner.ThenAsync("the user\'s score should increase by 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User answers a quiz question incorrectly and goes to the next question")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public async System.Threading.Tasks.Task UserAnswersAQuizQuestionIncorrectlyAndGoesToTheNextQuestion()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("User answers a quiz question incorrectly and goes to the next question", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 17
 await testRunner.GivenAsync("the quiz is started", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 18
 await testRunner.AndAsync("a question is displayed asking for a cardinal number", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 19
 await testRunner.WhenAsync("the user inputs the incorrect answer", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 20
 await testRunner.AndAsync("the user clicks on the next question button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 21
 await testRunner.ThenAsync("the user\'s score should increase by 0", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User answers a quiz question correctly and checks their answer")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public async System.Threading.Tasks.Task UserAnswersAQuizQuestionCorrectlyAndChecksTheirAnswer()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("User answers a quiz question correctly and checks their answer", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 25
 await testRunner.GivenAsync("the quiz is started", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 26
 await testRunner.AndAsync("a question is displayed asking for a cardinal number", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 27
 await testRunner.WhenAsync("the user inputs the correct answer", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 28
 await testRunner.AndAsync("the user clicks on the check answer button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 29
 await testRunner.ThenAsync("the system should display the correct answer", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User answers a quiz question incorrectly")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public async System.Threading.Tasks.Task UserAnswersAQuizQuestionIncorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("User answers a quiz question incorrectly", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 33
 await testRunner.GivenAsync("the quiz is started", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 34
 await testRunner.AndAsync("a question is displayed asking for a cardinal number", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 35
 await testRunner.WhenAsync("the user inputs the incorrect answer", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 36
 await testRunner.AndAsync("the user clicks on the check answer button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 37
 await testRunner.ThenAsync("the system should display the correct answer", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 38
 await testRunner.AndAsync("the user\'s score should increase by 0", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Each question should ask for a random cardinal number and no questions can be the" +
            " same")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public async System.Threading.Tasks.Task EachQuestionShouldAskForARandomCardinalNumberAndNoQuestionsCanBeTheSame()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Each question should ask for a random cardinal number and no questions can be the" +
                    " same", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 41
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 42
 await testRunner.GivenAsync("the quiz is started", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 43
 await testRunner.WhenAsync("the user completes the quiz", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 44
 await testRunner.ThenAsync("each question should be different", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The quiz should start when a user starts the quiz with a click")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public async System.Threading.Tasks.Task TheQuizShouldStartWhenAUserStartsTheQuizWithAClick()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath",
                    "Smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("The quiz should start when a user starts the quiz with a click", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 48
 await testRunner.GivenAsync("the user opens the quiz page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 49
 await testRunner.WhenAsync("the user starts the quiz", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 50
 await testRunner.ThenAsync("the question should be displayed", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 51
 await testRunner.AndAsync("the current question number should be 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 52
 await testRunner.AndAsync("the score should be 0", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
