using System;


public class Scores: MonoBehaviour {
  int score;
  
  GameObject scoreBox = GameObject.GetComponent<Text>();
  
  //Types of scoring
  
  void BlockDown (int level) {
    
  }
  
  
  void HardDrop (int level, int height) {
    
  }
  
  void LineClear (int level, int lines, bool ts, bool perfect, bool b2b) {
    if (perfect) {
      if (ts) {
        
      } else {
        
      }
      
    } else {
      if (ts) {
        
      } else {
        
      }
    }
  }
  
  void Update() {
    // Updates score
    scoreBox.text = Convert.ToString(score);
  }
  
  
}
