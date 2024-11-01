Feature: PlanAJourney

Verify the functionality of the "Plan a journey" widget on the TfL website.

@planAJourney
Scenario: Plan a valid journey from Leicester Square to Covent Garden
    Given I am on the TfL homepage
    When I enter "Leicester Square Underground Station" as the starting point
    And I enter "Covent Garden Underground Station" as the destination
    And I select a suggested location from the autocomplete list
    And I choose "walking" as the travel option
    And I submit the journey
    Then I should see the journey details
    And the walking and cycling times should be displayed
