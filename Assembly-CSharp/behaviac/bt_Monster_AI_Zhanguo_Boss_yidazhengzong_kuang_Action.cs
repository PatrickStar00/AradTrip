﻿using System;

namespace behaviac
{
	// Token: 0x02003EBD RID: 16061
	public static class bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action
	{
		// Token: 0x060164F8 RID: 91384 RVA: 0x006BF42C File Offset: 0x006BD82C
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Zhanguo/Boss_yidazhengzong_kuang_Action");
			bt.IsFSM = false;
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(24);
			bt.AddChild(selector);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(17);
			selector.AddChild(sequence);
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node18 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node18();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node.SetId(18);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node20 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node20();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2.SetId(20);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node21 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node21();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3.SetId(21);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node19 action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node = new Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node19();
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node.SetId(19);
			sequence.AddChild(action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(1);
			selector.AddChild(sequence2);
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4.SetId(3);
			sequence2.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5.SetId(2);
			sequence2.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6.SetId(6);
			sequence2.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node7 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node7.SetId(4);
			sequence2.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node7);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node7.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5 action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2 = new Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5();
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2.SetId(5);
			sequence2.AddChild(action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node2.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(7);
			selector.AddChild(sequence3);
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node8 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node8 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node8();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node8.SetId(8);
			sequence3.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node8);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node8.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node10 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node9 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node10();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node9.SetId(10);
			sequence3.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node9);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node9.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node11 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node10 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node11();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node10.SetId(11);
			sequence3.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node10);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node10.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node12 action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3 = new Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node12();
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3.SetId(12);
			sequence3.AddChild(action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node3.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(9);
			selector.AddChild(sequence4);
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node13 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node11 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node13();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node11.SetId(13);
			sequence4.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node11);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node11.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node14 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node12 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node14();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node12.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node12.SetId(14);
			sequence4.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node12);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node12.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node15 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node13 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node15();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node13.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node13.SetId(15);
			sequence4.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node13);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node13.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node16 action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4 = new Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node16();
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4.SetId(16);
			sequence4.AddChild(action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node4.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence4.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(29);
			selector.AddChild(sequence5);
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node30 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node14 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node30();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node14.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node14.SetId(30);
			sequence5.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node14);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node14.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node31 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node15 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node31();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node15.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node15.SetId(31);
			sequence5.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node15);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node15.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node32 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node16 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node32();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node16.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node16.SetId(32);
			sequence5.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node16);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node16.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node33 action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5 = new Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node33();
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5.SetId(33);
			sequence5.AddChild(action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node5.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence5.HasEvents());
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(0);
			selector.AddChild(sequence6);
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node22 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node17 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node22();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node17.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node17.SetId(22);
			sequence6.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node17);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node17.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node23 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node18 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node23();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node18.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node18.SetId(23);
			sequence6.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node18);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node18.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node25 condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node19 = new Condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node25();
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node19.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node19.SetId(25);
			sequence6.AddChild(condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node19);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node19.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node26 action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6 = new Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node26();
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6.SetId(26);
			sequence6.AddChild(action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node6.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence6.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | selector.HasEvents());
			return true;
		}
	}
}
