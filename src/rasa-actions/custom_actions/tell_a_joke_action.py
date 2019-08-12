from rasa_core_sdk import Action

class TellAJokeAction(Action):
    '''
    获取笑话资源
    '''
    def name(self):
        return "action_tell_a_joke"
  
    def run(self, dispatcher, tracker, domain):
        # send utter default template to user
        dispatcher.utter_message("从前有座山")
        # ... other code
        return []