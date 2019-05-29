Feature: UserRegistration
	In order to register a new user
	As a valid user
	I want to create a new user

@User Registration
Scenario: Create a new account
	Given I have new user details 
	And I have not logged in
	When I complete the sign up form
	Then my username must be displayed
