from rasa_core_sdk import Action

class ActionTellJokes(Action):
    def name(self):
        return "action_tell_jokes"
  
    def run(self, dispatcher, tracker, domain):
        # send utter default template to user
        dispatcher.utter_message("从前有座山", tracker)
        # ... other code
        return []