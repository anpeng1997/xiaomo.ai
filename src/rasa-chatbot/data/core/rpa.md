## 付款申请
* rpa.application_for_payment
  - action_search_payment_projects
  - application_for_payment_form
  - form{"name": "application_for_payment_form"}
  - slot{"requested_slot":"project_num"}
* form:inform{"project_num":""}
  - form{"name": "application_for_payment_form"}
  - slot{"project_num":""}
  - slot{"requested_slot":"money"}
* form:inform{"money":"0"}
  - form{"name": "application_for_payment_form"}
  - slot{"money":"0"}
  - slot{"requested_slot":"acceptance_slip_num"}
