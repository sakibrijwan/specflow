Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Login to get home page
	Given Hit the URL
	And I have entered userame <username>
	And I have entered password <password>
	When I press Login button
	Then the home page appears
Examples: 
| username              | password  |
| testnilavo1@gmail.com | Nilavo2006|
