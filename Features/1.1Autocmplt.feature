Feature: Autocmplt

Verify Autocomplete feature is working

@autocmp
Scenario: AutoComplete
	Given I am on the TfL homepage
    When I enter "Leicester Square" as the starting point
    And I found matching suggestion for "Leicester Square" as "Leicester Square Underground Station"
    And I enter "Covent Garden" as the destination
    And I found matching suggestion for "Covent Garden" as "Covent Garden Underground Station"
    And I submit the journey
    And I click on edit journey
    And I select walking
    And I select cycling



    
    
    

