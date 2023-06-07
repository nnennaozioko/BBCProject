Feature: Registeration

As a bbc user
I want to register
so that I can have access to the website

@tag1
Scenario: [To verify valid Registration ]
	Given user navigates to "https://www.bbc.co.uk/"
	When user clicks sign in 
	And user clicks register now
	And user clicks thirteenOrOver
	And user enters day "20"
	And user enters month "12"
	And user enters year "1990"
	And user clicks continue button
	And user enters email address "estina14@yahoo.com"
	And user enters password "Cap2222!"
	And user enters postcode "SS14 2EJ"
	And user selects gender 
	And user clicks register button
	Then OK you’re signed in. Now, want to keep up to date?
	


