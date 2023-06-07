Feature: Menu

As a user
I want to access BBC landingpage
So tha I view options

@tag1
Scenario Outline: Common Menu
	Given user navigates to "https://www.bbc.co.uk/"
	When user clicks on "<menuItem>"
    #Then landing page should displayed
	Then land page should display "<pageTitle>"

Examples: 
| menuItem |          pageTitle      |
| Home     |    Welcome to the BBC   |
| News     |    NEWS                 |
| Sport    |    SPORT                |
| Weather  |    WEATHER              |
| iPlayer  |    iPLAYER              |
| Sounds   |    SOUNDS               |
| Bitesize |    BITESIZE             |
