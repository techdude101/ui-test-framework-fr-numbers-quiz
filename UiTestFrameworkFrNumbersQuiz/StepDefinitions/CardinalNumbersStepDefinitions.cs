using CsvHelper;
using NUnit.Framework;
using Reqnroll;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UiTestFrameworkFrNumbersQuiz.Models;
using UiTestFrameworkFrNumbersQuiz.Pages;
using UiTestFrameworkFrNumbersQuiz.Utilities;

namespace UiTestFrameworkFrNumbersQuiz.StepDefinitions
{
    [Binding]
    public class CardinalNumbersStepDefinitions : BaseDriver
    {
        private readonly QuizPage quizPage = new QuizPage(webDriver);
        private int cardinalNumber;
        private int currentScore;
        private string correctAnswer;
        private string fileName = "TestData.cardinal_numbers_fr.csv";
        List<string> questions;

        [Given("the quiz is started")]
        public void GivenTheQuizIsStarted()
        {
            string expectedTitle = "French Quiz - Numbers";
            quizPage.Open();
            quizPage.VerifyPageTitle(expectedTitle);
            quizPage.VerifyPageHeading(expectedTitle);
            quizPage.StartQuiz();
        }

        [Given("the user opens the quiz page")]
        public void GivenTheUserOpensTheQuizPage()
        {
            quizPage.Open();
        }

        [Given("a question is displayed asking for a cardinal number")]
        public void GivenAQuestionIsDisplayedAskingForTheCardinalNumberOf()
        {
            cardinalNumber = quizPage.GetQuestion();
        }

        [When("the user inputs the correct answer")]
        public void WhenTheUserInputsTheCorrectAnswer()
        {

            List<NumbersTranslations> numbersTranslations = FileIO.ReadTranslationFile<NumbersTranslations>(fileName);

            NumbersTranslations correctTranslation = numbersTranslations.Where(x => x.number == cardinalNumber).ToList()[0];
            
            this.correctAnswer = correctTranslation.translation;
            
            quizPage.EnterAnswer(this.correctAnswer);
        }

        [When("the user clicks on the next question button")]
        public void WhenTheUserClicksOnTheNextQuestionButton()
        {
            quizPage.ClickOnTheNextQuestionButton();
        }

        [When("the user clicks on the check answer button")]
        public void WhenTheUserClicksOnTheCheckAnswerButton()
        {
            quizPage.ClickOnTheCheckAnswerButton();
        }

        [When("the user starts the quiz")]
        public void WhenTheUserStartsTheQuiz()
        {
            quizPage.StartQuiz();
        }

        [When("the user completes the quiz")]
        public void WhenTheUserCompletesTheQuiz()
        {
            List<string> answers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            this.questions = quizPage.CompleteQuiz(answers);
        }

        [When("the user inputs the incorrect answer")]
        public void WhenTheUserInputsTheIncorrectAnswer()
        {
            List<NumbersTranslations> numbersTranslations = FileIO.ReadTranslationFile<NumbersTranslations>(fileName);

            NumbersTranslations correctTranslation = numbersTranslations.Where(x => x.number == cardinalNumber).ToList()[0];

            this.correctAnswer = correctTranslation.translation;

            quizPage.EnterAnswer("abc1234567890");
        }

        [Then("the system should display the correct answer")]
        public void ThenTheSystemShouldShowTheCorrectAnswer()
        {
            //string expectedText = "Correct answer:\n" + this.correctAnswer;
            string expectedText = string.Format("Correct answer:\r\n{0} = {1}", this.cardinalNumber, this.correctAnswer);
            quizPage.VerifyCorrectAnswer(expectedText);
        }

        [Then("the user's score should increase by {int}")]
        public void ThenTheUsersScoreShouldIncreaseBy(int scoreIncrement)
        {
            quizPage.VerifyScore("Score: " + (currentScore + scoreIncrement));
        }

        [Then("each question should be different")]
        public void ThenEachQuestionShouldBeDifferent()
        {
            var duplicates = this.questions.GroupBy(x => x)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key);
            
            Assert.That(duplicates.Any() == false);
        }

        [Then("the question should be displayed")]
        public void ThenTheQuestionShouldBeDisplayed()
        {
            throw new PendingStepException();
        }

        [Then("the current question number should be {string}")]
        public void ThenTheCurrentQuestionNumberShouldBe(int expectedQuestionNumber)
        {
            throw new PendingStepException();
        }

        [Then("the score should be {string}")]
        public void ThenTheScoreShouldBe(int expectedScore)
        {
            throw new PendingStepException();
        }
    }
}
