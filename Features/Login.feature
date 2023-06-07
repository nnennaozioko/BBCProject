Feature: Login

As a BBC user
I want to login 
So that I can check what is new

@tag1
Scenario: [To verify invalid Login]
	Given user navigates to "https://www.bbc.co.uk/"
	When user clicks sign in
	And user enters email address "estina@yahoo.com"
	And user enters password "Cap2222!"
	And user clicks sign in button
	#Then message displayed
