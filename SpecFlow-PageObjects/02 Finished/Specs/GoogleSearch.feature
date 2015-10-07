Feature: Google Search
  As an internet user
  I want to search for “SOLID principles”
  So that I can be knowledgeable about the organzation

@UI
Scenario: Search for ‘SOLID principles’
  Given I am on the Google Home Page
  When I search for 'Solid Principles'
  Then I should see the wikipedia page 
  And I should see over 100,000 results
  