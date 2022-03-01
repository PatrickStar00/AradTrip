﻿using System;

namespace behaviac
{
	// Token: 0x02003ECF RID: 16079
	public static class bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action
	{
		// Token: 0x0601651B RID: 91419 RVA: 0x006C03E4 File Offset: 0x006BE7E4
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Zhanguo/Boss_zhentianxincun_Action");
			bt.IsFSM = false;
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(24);
			bt.AddChild(selector);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(1);
			selector.AddChild(sequence);
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node.SetId(3);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2.SetId(2);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node6 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node6();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3.SetId(6);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4.SetId(4);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node5 action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node = new Action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node5();
			action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node.SetId(5);
			sequence.AddChild(action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(7);
			selector.AddChild(sequence2);
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node8 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node5 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node8();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node5.SetId(8);
			sequence2.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node5);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node5.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node10 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node6 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node10();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node6.SetId(10);
			sequence2.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node6);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node6.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node11 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node7 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node11();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node7.SetId(11);
			sequence2.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node7);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node7.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node12 action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2 = new Action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node12();
			action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2.SetId(12);
			sequence2.AddChild(action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node2.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(9);
			selector.AddChild(sequence3);
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node13 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node8 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node13();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node8.SetId(13);
			sequence3.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node8);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node8.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node14 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node9 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node14();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node9.SetId(14);
			sequence3.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node9);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node9.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node0 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node10 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node0();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node10.SetId(0);
			sequence3.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node10);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node10.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node15 action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3 = new Action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node15();
			action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3.SetId(15);
			sequence3.AddChild(action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node3.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(17);
			selector.AddChild(sequence4);
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node18 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node11 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node18();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node11.SetId(18);
			sequence4.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node11);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node11.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node19 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node12 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node19();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node12.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node12.SetId(19);
			sequence4.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node12);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node12.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node20 condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node13 = new Condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node20();
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node13.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node13.SetId(20);
			sequence4.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node13);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node13.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node16 action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4 = new Action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node16();
			action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4.SetId(16);
			sequence4.AddChild(action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_zhentianxincun_Action_node4.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence4.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | selector.HasEvents());
			return true;
		}
	}
}
