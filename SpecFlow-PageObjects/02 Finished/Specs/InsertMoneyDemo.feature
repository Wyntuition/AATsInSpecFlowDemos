Feature: InsertMoneyDemo
	As a customer
	So I can ensure I get my money's worth
	Caluculate how much I deposited

@mytag
Scenario: Add money to the register
	Given I have a quarter 
	When I insert it into the register
	Then I should see the amount I entered 