Feature: CardinalNumbers

  As a user,
  I want to take a quiz to test my knowledge of cardinal numbers,
  So that I can assess my understanding and improve my skills.

@HappyPath
Scenario: User answers a quiz question correctly and goes to the next question
	Given the quiz is started
	And a question is displayed asking for a cardinal number
	When the user inputs the correct answer
	And the user clicks on the next question button
	Then the user's score should increase by 1

@HappyPath
Scenario: User answers a quiz question incorrectly and goes to the next question
	Given the quiz is started
	And a question is displayed asking for a cardinal number
	When the user inputs the incorrect answer
	And the user clicks on the next question button
	Then the user's score should increase by 0

@HappyPath
Scenario: User answers a quiz question correctly and checks their answer
	Given the quiz is started
	And a question is displayed asking for a cardinal number
	When the user inputs the correct answer
	And the user clicks on the check answer button
	Then the system should display the correct answer

@HappyPath
Scenario: User answers a quiz question incorrectly
	Given the quiz is started
	And a question is displayed asking for a cardinal number
	When the user inputs the incorrect answer
	And the user clicks on the check answer button
	Then the system should display the correct answer
	And the user's score should increase by 0

@HappyPath
Scenario: Each question should ask for a random cardinal number and no questions can be the same
	Given the quiz is started
	When the user completes the quiz
	Then each question should be different

@HappyPath @Smoke
Scenario: The quiz should start when a user starts the quiz with a click
	Given the user opens the quiz page
	When the user starts the quiz
	Then the question should be displayed
	And the current question number should be 1
	And the score should be 0
