Feature: Person
	In order to know how old people are
	As a user
	I want to be told peoples' ages

@mytag
Scenario: Get person's age
	Given I have entered "John Smith" with a birthday of I have entered "1/1/1980"
	When I calculate age
	Then the result should be 33

