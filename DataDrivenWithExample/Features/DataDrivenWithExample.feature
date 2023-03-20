Feature: DataDrivenWithExample

A short summary of the feature

@tag1

Scenario Outline: Data Driven With Example
	Given I navigate to the Website 
	And I click on Sign Up
	And I enter Username text "<Username>"
	And I enter Email text "<Email>"
	And I enter Password text "<Password>"
	When I click on Sign up botton 
	Then I should be able to register successfully 


	Examples: 
	| Username | Email          | Password |
	| Dayo     | deji@gmail.com | deji40   |
	| Titi     | teti@yahoo.com | tety     |
	| Tayo     | tayo@yahoo.com | tayo98   |