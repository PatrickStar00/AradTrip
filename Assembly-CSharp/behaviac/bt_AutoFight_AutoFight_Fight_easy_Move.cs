﻿using System;

namespace behaviac
{
	// Token: 0x02001F71 RID: 8049
	public static class bt_AutoFight_AutoFight_Fight_easy_Move
	{
		// Token: 0x06012884 RID: 75908 RVA: 0x0056D508 File Offset: 0x0056B908
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("AutoFight/AutoFight_Fight_easy_Move");
			bt.IsFSM = false;
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(0);
			bt.AddChild(selector);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(1);
			selector.AddChild(sequence);
			Condition_bt_AutoFight_AutoFight_Fight_easy_Move_node3 condition_bt_AutoFight_AutoFight_Fight_easy_Move_node = new Condition_bt_AutoFight_AutoFight_Fight_easy_Move_node3();
			condition_bt_AutoFight_AutoFight_Fight_easy_Move_node.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_easy_Move_node.SetId(3);
			sequence.AddChild(condition_bt_AutoFight_AutoFight_Fight_easy_Move_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_easy_Move_node.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_easy_Move_node2 action_bt_AutoFight_AutoFight_Fight_easy_Move_node = new Action_bt_AutoFight_AutoFight_Fight_easy_Move_node2();
			action_bt_AutoFight_AutoFight_Fight_easy_Move_node.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_easy_Move_node.SetId(2);
			sequence.AddChild(action_bt_AutoFight_AutoFight_Fight_easy_Move_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_AutoFight_AutoFight_Fight_easy_Move_node.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(4);
			selector.AddChild(sequence2);
			Condition_bt_AutoFight_AutoFight_Fight_easy_Move_node5 condition_bt_AutoFight_AutoFight_Fight_easy_Move_node2 = new Condition_bt_AutoFight_AutoFight_Fight_easy_Move_node5();
			condition_bt_AutoFight_AutoFight_Fight_easy_Move_node2.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_easy_Move_node2.SetId(5);
			sequence2.AddChild(condition_bt_AutoFight_AutoFight_Fight_easy_Move_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_easy_Move_node2.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_easy_Move_node6 action_bt_AutoFight_AutoFight_Fight_easy_Move_node2 = new Action_bt_AutoFight_AutoFight_Fight_easy_Move_node6();
			action_bt_AutoFight_AutoFight_Fight_easy_Move_node2.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_easy_Move_node2.SetId(6);
			sequence2.AddChild(action_bt_AutoFight_AutoFight_Fight_easy_Move_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_AutoFight_AutoFight_Fight_easy_Move_node2.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence2.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | selector.HasEvents());
			return true;
		}
	}
}
