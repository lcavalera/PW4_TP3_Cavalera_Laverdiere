<template>
    <div>
    <label>Titre: </label><input id="titre" type="text" v-model="todo.text" :disabled="!isEdit">
    </div><br>
    <div>
    <label>Completé: </label><input id="status" type="checkbox" v-model="todo.done" :disabled="!isEdit">
    </div><br>
    <div>
    <label>Categorie: </label>
    <select name="categories" id="categorie" v-model="todo.category" :disabled="!isEdit">
      <option v-for="(item, index) in categories" :key="index" :value="item">{{ item }}</option>
    </select>
    </div>
    </template>
    
    <script>
    import { mapState, mapActions } from 'vuex'
    import httpclient from '@/api/httpclient'
    
    export default {
      name: "TodoForm",
      props: {
        titre: String,
      },
      data() {
        return {
          todo: {},
          isEdit: false
        };
      },
      methods: {
        ...mapActions({ getData: 'getData'}),
        getTodoApi(id){
          httpclient.get(`Todos/${id}`)
          .then(reponse => this.todo = reponse.data)
          .catch(error => console.log(error))
        },
        getCategorieApi(){
          httpclient.get(`categorie`)
          .then(reponse => this.categorie = reponse.data)
          .catch(error => console.log(error))
        }
      },
      created(){
        this.isEdit = this.$route.params.action === 'edit'
        this.getTodoApi(this.$route.params.id)
        this.getData()
      },
      computed: {
        ...mapState({ categories: 'categories'})
      }
    };
    </script>
    
    <style scoped>
    .done {
      background: rgb(7, 240, 7);
    }
    
    button,
    [aria-label] {
      cursor: pointer;
    }
    
    table {
      font-family: Arial, sans-serif;
      border: 1px solid;
      border-collapse: collapse;
      width: 100%;
    }
    
    th {
      background-color: #f8f8f8;
      padding: 5px;
    }
    
    td {
      border: 1px solid;
      padding: 5px;
    }
    </style>