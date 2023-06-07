Feature: News

As a BBC user
I want to navigate to News landing page
So that I veiw the contents

@tag1
Scenario Outline: News Menu
	Given user navigates to "https://www.bbc.co.uk/"
	When user clicks News menu
	And user clicks on "<newsmenuitem>"
	And user clicks on more dropdown
	And user clicks on "<moremenuitems>"
	Then news page should display "<newsMenuPageTitle>"

Examples: 
| newsmenuItem       |    NewsMenupageTitle  |
| Home               |    HOME               |
| CostOfLiving       |    COSTOFLIVING       |
| WarInUkraine       |    SWARINUKRAINE      |
| Climate            |    CLIMATE            |
| UK                 |    UK                 |
| World              |    WORLD              |
| Business           |    BUSINESS           |
| Politics           |    POLITICS           |
| Culture            |    CULTURE            |
| Science            |    SCIENCE            |
| Health             |    HEALTH             |
| Family&Educatition |    FAMILY&EDUCATION   |
| InPicture          |    INPICTURE          |
|  MoreDropdown      |    MOREDROPDOWN       |
|  Newsbeat          |    NEWSBEAT           |
|  RealityCheck      |    REALITYCHECK       |         
|  Disability        |    DISABILITY         |      