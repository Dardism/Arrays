using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//High-level interface OOP
namespace Arrays {
  class HighArray {
    private long[] _arr; //ref to array
    private int nElems; //number of data items

    public HighArray(int size) {
      _arr = new long[size];
      nElems = 0;
    }
    //*********************************************
    public bool find(long searchKey) {
      int j;
      for (j = 0; j < nElems; j++) {
        if (_arr[j] == searchKey) {
          break;
        }
      }
      if (j == nElems) {
        return false;
      }
      else { 
        return true;
      }
    }
    //*********************************************
    public void insert(long value) {
      _arr[nElems] = value;
      nElems++;
    }
    //*********************************************
    public bool delete(long value) {
      int j;
      for (j = 0; j < nElems; j++) {
        if (value == _arr[j]) {
          break;
        }
      }
      if (j == nElems) { //cant find value
        return false;
      }
      else {
        for (int k = j; k < nElems; k++) {
          _arr[k] = _arr[k + 1];
        }
        nElems--;
        return true;
      }
    }
    //*********************************************
    public void display() {
      for (int j = 0; j < nElems; j++) {
        Console.Write(_arr[j] + " ");
        Console.WriteLine("");
      }
    }


  }
}
