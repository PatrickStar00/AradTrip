﻿using System;

namespace behaviac
{
	// Token: 0x020030E1 RID: 12513
	public static class bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event
	{
		// Token: 0x06014A77 RID: 84599 RVA: 0x00638334 File Offset: 0x00636734
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Chapter10/Dashengqishi_Douqi_Event");
			bt.IsFSM = false;
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(0);
			bt.AddChild(sequence);
			Condition_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node3 condition_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node = new Condition_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node3();
			condition_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node.SetId(3);
			sequence.AddChild(condition_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node.HasEvents());
			Action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node4 action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node = new Action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node4();
			action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node.SetId(4);
			sequence.AddChild(action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node.HasEvents());
			Action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node2 action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node2 = new Action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node2();
			action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node2.SetId(2);
			sequence.AddChild(action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node2);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Chapter10_Dashengqishi_Douqi_Event_node2.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | sequence.HasEvents());
			return true;
		}
	}
}
