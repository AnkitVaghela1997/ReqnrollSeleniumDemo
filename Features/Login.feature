Feature: Login
  Scenario: Successful login
    Given the user navigates to the login page
    When the user enters valid credentials
    Then the user should be redirected to the products page
