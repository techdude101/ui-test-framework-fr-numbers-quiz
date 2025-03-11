using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UiTestFrameworkFrNumbersQuiz.Pages
{
    public class QuizPage : BasePage
    {
        IWebDriver webDriver;

        // region element selectors
        private static string SELECTOR_TAG_PAGE_HEADING = "h1";
        private static string SELECTOR_ID_QUESION_LABEL = "questionLabel";
        private static string SELECTOR_ID_QUESTION_INPUT = "answerInput";
        private static string SELECTOR_ID_START_QUIZ_BUTTON = "startQuizButton";
        private static string SELECTOR_ID_CHECK_ANSWER_BUTTON = "checkAnswerButton";
        private static string SELECTOR_ID_NEXT_QUESTION_BUTTON = "nextQuestionButton";
        private static string SELECTOR_ID_CORRECT_ANSWER_TEXT = "correctAnswerParagraph";
        private static string SELECTOR_XPATH_SCORE_TEXT = "//p[contains(text(), 'Score:')]";
        // endregion element selectors

        public QuizPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        public void Open()
        {
            this.webDriver.Navigate().GoToUrl(baseUrl);
        }

        public void VerifyPageTitle(string expectedTitle)
        {
            Assert.That(webDriver.Title, Is.EqualTo(expectedTitle));
        }

        public void VerifyPageHeading(string expectedHeading)
        {
            string actualHeading = webDriver.FindElement(By.TagName(SELECTOR_TAG_PAGE_HEADING)).Text;
            Assert.That(actualHeading, Is.EqualTo(expectedHeading));
        }

        public void VerifyScore(string expectedText)
        {
            string actualText = webDriver.FindElement(By.XPath(SELECTOR_XPATH_SCORE_TEXT)).Text;
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        public void VerifyCorrectAnswer(string expectedText)
        {
            string actualText = webDriver.FindElement(By.Id(SELECTOR_ID_CORRECT_ANSWER_TEXT)).Text;
            WaitForElementToBeDisplayed(By.Id(SELECTOR_ID_CORRECT_ANSWER_TEXT), elementTimeoutInSeconds);
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        public void StartQuiz()
        {
            webDriver.FindElement(By.Id(SELECTOR_ID_START_QUIZ_BUTTON)).Click();
        }

        public int GetQuestion()
        {
            string questionText = webDriver.FindElement(By.Id(SELECTOR_ID_QUESION_LABEL)).Text;
            int number = Int32.Parse(questionText.Split("=")[0]);
            return number;
        }

        public string GetQuestionText()
        {
            string questionText = webDriver.FindElement(By.Id(SELECTOR_ID_QUESION_LABEL)).Text;
            return questionText;
        }

        public void ClickOnTheNextQuestionButton()
        {
            webDriver.FindElement(By.Id(SELECTOR_ID_NEXT_QUESTION_BUTTON)).Click();
        }

        public void ClickOnTheCheckAnswerButton()
        {
            webDriver.FindElement(By.Id(SELECTOR_ID_CHECK_ANSWER_BUTTON)).Click();
        }

        public void EnterAnswer(string answer)
        {
            webDriver.FindElement(By.Id(SELECTOR_ID_QUESTION_INPUT)).SendKeys(answer);
        }

        public List<string> CompleteQuiz(List<string> answers)
        {
            List<string> questions = new List<string>();

            foreach (string answer in answers)
            {
                string question = GetQuestionText();
                questions.Add(question);
                
                EnterAnswer(answer);
                ClickOnTheNextQuestionButton();
            }

            return questions;
        }
    }
}
