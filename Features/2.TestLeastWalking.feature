Feature: EditPreferences

A short summary of the feature

@tag1
Scenario: Edit preferences to select routes with the least walking
Given I am on the TfL homepage
  When I enter "Leicester Square Underground Station" as the starting point
  And I enter "Covent Garden Underground Station" as the destination1
  
  And scroll up to the webpage
  And Click on edit preference
  And Select Routes with least walking
  And Update journey
  