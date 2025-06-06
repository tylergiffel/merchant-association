# API Requirements

## CRUD Endpoints

- Implement an endpoint to update Business entities.

## Phone Number Validation

### Requirements

- Implement phone number validation using the numverify API (https://numverify.com/documentation)
- Validation should occur when:
  - Creating a new owner with a phone number
  - Updating an existing owner's phone number

## Events

### Requirements

Businesses need to be able to add Events that they can display on their business page on the merchant site. These events need a name, description and start/end dates. Most of the events are one-off (Pacers watch party), but some recur on weekly and monthly intervals (trivia nights).

The API should provide an endpoint to list all of the events.

## Stretch Goals/Ideas

- Add unit tests
- Add validation
- Add an API level middleware (logging/etc)
- Add audit/timestamp properties to the entities
