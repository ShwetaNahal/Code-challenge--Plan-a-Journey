Feature: InvalidJourney

Plan an Invalid journey

@Invalid
Scenario: Plan an invalid journey
  Given I am on the TfL homepage
  When I enter "Leicester Square Underground Station" as the starting point
  And I enter "456tghy" as the destination
  Then I should see no journey results