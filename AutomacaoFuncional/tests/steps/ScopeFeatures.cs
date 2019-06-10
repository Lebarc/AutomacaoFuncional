using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    class ScopeFeatures
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureInfo featureInfo)
        {
            ClassDriver.GetInstance().StartDriver();
        }

        [BeforeScenario]
        public static void BeforeScenario(FeatureInfo featureInfo)
        {
           
        }

        [BeforeStep]
        public static void BeforeStep()
        {

        }

        [AfterStep]
        public static void AfterStep()
        {
            Assert.True(ClassInfo.GetInstance().ResultScenario, ClassInfo.GetInstance().LogMessage, null);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            //Assert.True(ClassInfo.GetInstance().ResultScenario, ClassInfo.GetInstance().LogMessage, null);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            ClassDriver.GetInstance().QuitDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {

        }           
    }
}
