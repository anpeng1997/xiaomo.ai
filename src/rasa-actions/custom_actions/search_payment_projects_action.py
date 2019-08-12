from rasa_core_sdk import Action
import json


class SearchPaymentProjectsAction(Action):
    '''
    获取所有付款项目
    '''

    def name(self):
        return "action_search_payment_projects"

    def run(self, dispatcher, tracker, domain):

        result = {
            "text": "选择项目",
            "list": [
                {"title": "云策Azure部署规划1（2018071801HZ）", "payload": "/inform{\"project_num\":\"2018071801HZ\"}"},
                {"title": "云策Azure部署规划2（2018071802HZ）", "payload": "/inform{\"project_num\":\"2018071802HZ\"}"},
                {"title": "云策Azure部署规划3（2018071803HZ）", "payload": "/inform{\"project_num\":\"2018071803HZ\"}"}
            ]
        }

        dispatcher.utter_custom_json(result)
        return []
