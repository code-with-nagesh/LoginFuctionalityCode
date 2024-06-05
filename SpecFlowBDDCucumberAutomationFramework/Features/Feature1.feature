Feature: feature to test login functionality

test the login functinality

@login
Scenario: Check login is successful with valid credentials
	Given Open the browser
	When user is on login page
	And When user enters username and password
	And user clicks on login
    Then user is navigated to the home page