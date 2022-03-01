﻿using System;

namespace behaviac
{
	// Token: 0x0200334B RID: 13131
	public static class bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event
	{
		// Token: 0x06014EF9 RID: 85753 RVA: 0x0064EEAC File Offset: 0x0064D2AC
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/GoblinKingdom/Goblin_liebing_xiashu_Event");
			bt.IsFSM = false;
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(0);
			bt.AddChild(sequence);
			Action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node6 action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node = new Action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node6();
			action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node.SetId(6);
			sequence.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node.HasEvents());
			Condition_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node1 condition_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node = new Condition_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node1();
			condition_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node.SetId(1);
			sequence.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node2 action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node2 = new Action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node2();
			action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node2.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node2.SetId(2);
			sequence.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node2);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node2.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node5 action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node3 = new Action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node5();
			action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node3.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node3.SetId(5);
			sequence.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node3);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblin_liebing_xiashu_Event_node3.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | sequence.HasEvents());
			return true;
		}
	}
}
