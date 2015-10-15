Feature: Search Google
  As an internet user
  I want to search for “ALT.NET”
  So that I can be knowledgeable about the organzation

@UI
Scenario: Search for "ALT.NET"
  Given I am on the Google Home Page
  When I search for ”ALT.NET"
  Then I should see results