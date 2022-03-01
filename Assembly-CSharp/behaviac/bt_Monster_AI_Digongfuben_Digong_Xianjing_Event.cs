﻿using System;

namespace behaviac
{
	// Token: 0x0200329B RID: 12955
	public static class bt_Monster_AI_Digongfuben_Digong_Xianjing_Event
	{
		// Token: 0x06014DAF RID: 85423 RVA: 0x006483A4 File Offset: 0x006467A4
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Digongfuben/Digong_Xianjing_Event");
			bt.IsFSM = false;
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(0);
			bt.AddChild(sequence);
			Condition_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node4 condition_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node = new Condition_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node4();
			condition_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node.SetId(4);
			sequence.AddChild(condition_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node.HasEvents());
			Action_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node3 action_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node = new Action_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node3();
			action_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node.SetClassNameString("Action");
			action_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node.SetId(3);
			sequence.AddChild(action_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node.HasEvents());
			Assignment_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node5 assignment_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node = new Assignment_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node5();
			assignment_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node.SetId(5);
			sequence.AddChild(assignment_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | assignment_bt_Monster_AI_Digongfuben_Digong_Xianjing_Event_node.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | sequence.HasEvents());
			return true;
		}
	}
}
