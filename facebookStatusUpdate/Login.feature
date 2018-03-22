Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Login to get home page
	Given I have entered username
	And I have entered password
	When I press Login button
	Then the home page appears
