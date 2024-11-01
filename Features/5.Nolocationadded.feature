Feature: Nolocationadded

A short summary of the feature

@nolocation
Scenario: Add no location
  Given I am on the TfL homepage
  When I enter "" as the starting point
  And I enter "" as the destination
  And I submit the journey
  Then field validation error message should appear
