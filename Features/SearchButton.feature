Feature: SearchButton

As a BBC user
I want to search for food
So that I can have idea about food in BBC

@tag1
Scenario: [To verify search button]
	Given user navigates to "https://www.bbc.co.uk/"
	When user clicks search BBC button
	And user enters food and drink
	And user clicks food and drink series
    Then BBC News World Service should displayed
	When user clicks Episodes
	And user clicks German wine makes
	And user clicks listen now
	And user clicks Audio button
	And user clicks sign in
	And user enters email address "nelytino@yahoo.com"
	And user enters password "Cap2222!"
	And user clicks sign in button
	And user clicks video button
	Then sound should play
