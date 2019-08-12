# -*- coding: utf-8 -*-
from typing import Dict, Text, Any, List, Union, Optional

from rasa_sdk import Tracker
from rasa_sdk.executor import CollectingDispatcher
from rasa_sdk.forms import FormAction

class ApplicationForPaymentForm(FormAction):
    '''
    申请付款项目表单
    '''
    def name(self) -> Text:
        return "application_for_payment_form"

    @staticmethod
    def required_slots(tracker) -> List[Text]:
        return ["project_num", "money", "acceptance_slip_num"]


    def submit(self, dispatcher, tracker, domain) -> List[Dict]:
        dispatcher.utter_template("utter_submit", tracker)
        return []